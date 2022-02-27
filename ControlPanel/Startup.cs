using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPanel.DbContexts;
using ControlPanel.Helper;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanel.Repository;
using Elastic.Apm.NetCoreAll;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Exceptions;
using Serilog.Sinks.Elasticsearch;

namespace ControlPanel
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            JwtConfiguration(services);
            services.AddDbContext<iBOSContext>();

            services.AddScoped<IBusinessArea, Repository.BusinessArea>();
            services.AddScoped<IBusinessPartner, Repository.BusinessPartner>();
            services.AddScoped<IBusinessPartnerDistributionChannel, Repository.BusinessPartnerDistributionChannel>();            
            services.AddScoped<IBusinessPartnerTerritory, Repository.BusinessPartnerTerritory>();           
            services.AddScoped<IBusinessPartnerPurchase, Repository.BusinessPartnerPurchase>();
            services.AddScoped<IBusinessPartnerSales, Repository.BusinessPartnerSales>();
            services.AddScoped<IBusinessUnit, Repository.BusinessUnit>();
            services.AddScoped<IClient, Repository.Client>();
            services.AddScoped<ICountry, Repository.Country>();
            services.AddScoped<IDistributionChannel, Repository.DistributionChannel>();
            services.AddScoped<IDistrict, Repository.District>();
            services.AddScoped<IItem, Repository.Item>();
            services.AddScoped<IItemAttribute, Repository.ItemAttribute>();
            services.AddScoped<IItemAttributeConfig, Repository.ItemAttributeConfig>();
            services.AddScoped<IItemCategory, Repository.ItemCategory>();
            services.AddScoped<IItemMaster, Repository.ItemMaster>();
            services.AddScoped<IItemPlantWarehouse, Repository.ItemPlantWarehouse>();
            services.AddScoped<IItemPurchase, Repository.ItemPurchase>();
            services.AddScoped<IItemSales, Repository.ItemSales>();
            services.AddScoped<IItemSubCategory, Repository.ItemSubCategory>();
            services.AddScoped<IItemType, Repository.ItemType>();
            services.AddScoped<IItemUOMConversion, Repository.ItemUOMConversion>();
            services.AddScoped<ILogTerritorySalesForceChange, Repository.LogTerritorySalesForceChange>();
            services.AddScoped<IOutlet, Repository.Outlet>();
            services.AddScoped<IOutletTerritory, Repository.OutletTerritory>();
            services.AddScoped<IPlant, Repository.Plant>();
            services.AddScoped<IPlantWarehouse, Repository.PlantWarehouse>();            
            services.AddScoped<IProductDivision, Repository.ProductDivision>();
            services.AddScoped<ISalesArea, Repository.SalesArea>();
            services.AddScoped<ISalesForceTerritory, Repository.SalesForceTerritory>();
            services.AddScoped<ISalesOrganization, Repository.SalesOrganization>();
            services.AddScoped<ISoldToPartnerShipToPartner, Repository.SoldToPartnerShipToPartner>();
            services.AddScoped<ITerritory, Repository.Territory>();
            services.AddScoped<ITerritoryType, Repository.TerritoryType>();
            services.AddScoped<IUnitOfMeasurement, Repository.UnitOfMeasurement>();
            services.AddScoped<IUser, Repository.User>();
            services.AddScoped<IWarehouse, Repository.Warehouse>();
            services.AddScoped<IAccountCategory, Repository.AccountCategory>();
            services.AddScoped<IGeneralLedger, Repository.GeneralLedger>();
            services.AddScoped<IAccountingJournalTypeBusinessUnit, Repository.AccountingJournalTypeBusinessUnit>();
            services.AddScoped<IBankBranchBusinessUnit, Repository.BankBranchBusinessUnit>();
            services.AddScoped<IAlternativeAndStandardReconGeneralLedger, Repository.AlternativeAndStandardReconGeneralLedger>();
            services.AddScoped<IBusinessPartnerGeneralLedger, Repository.BusinessPartnerGeneralLedger>();
            services.AddScoped<IBusniessUnitGeneralLedger, Repository.BusniessUnitGeneralLedger>();
            services.AddScoped<IAccountClass, Repository.AccountClass>();
            services.AddScoped<IAccountGroup, Repository.AccountGroup>();
            services.AddScoped<IAccountingJournalType, Repository.AccountingJournalType>();
            services.AddScoped<IAccountingPostingType, Repository.AccountingPostingType>();
            services.AddScoped<IBank, Repository.Bank>();
            services.AddScoped<IBankAccount, Repository.BankAccount>();
            services.AddScoped<IBankBranch, Repository.BankBranch>();
            services.AddScoped<IBankInstrumentType, Repository.BankInstrumentType>();
            services.AddScoped<ICurrency, Repository.Currency>();
            services.AddScoped<IDepreciationType, Repository.DepreciationType>();
            services.AddScoped<IBusinessUnitCurrency, Repository.BusinessUnitCurrency>();
            services.AddScoped<IBusinessUnitCurrencyConversion, Repository.BusinessUnitCurrencyConversion>();
            services.AddScoped<IPriceListSalesOrgItem, Repository.PriceListSalesOrgItem>();
            services.AddScoped<IPriceListDistChannelTerritoryItem, Repository.PriceListDistChannelTerritoryItem>();
            services.AddScoped<IPriceListDistributionChannelItem, Repository.PriceListDistributionChannelItem>();
            services.AddScoped<IPriceListPartnerItem, Repository.PriceListPartnerItem>();
            services.AddScoped<IPriceSetup, Repository.PriceSetup>();
            services.AddScoped<IPurchaseOrganization, Repository.PurchaseOrganization>();
            services.AddScoped<IRoundingType, Repository.RoundingType>();
            services.AddScoped<IDeliveryRoute, Repository.DeliveryRoute>();
            services.AddScoped<IDeliveryType, Repository.DeliveryType>();
            services.AddScoped<IBalanceCheckType, Repository.BalanceCheckType>();
            services.AddScoped<IDepreciationType, Repository.DepreciationType>();
            services.AddScoped<IAccountingJournalType, Repository.AccountingJournalType>();
            services.AddScoped<IAccountingPostingType, Repository.AccountingPostingType>();
            services.AddScoped<IBankJournalHeader, Repository.BankJournalHeader>();
            services.AddScoped<IBankJournalRow, Repository.BankJournalRow>();           
            services.AddScoped<IAccountingJournal, Repository.AccountingJournal>();
            services.AddScoped<IAccountReceivablePayable, Repository.AccountReceivablePayable>();
            services.AddScoped<IAdjustmentJournalCommon, Repository.AdjustmentJournalCommon>();
            services.AddScoped<ITradeOfferItemGroupHeader, Repository.TradeOfferItemGroupHeader>();
            services.AddScoped<IPriceConditionTypeOrganization, Repository.PriceConditionTypeOrganization>();
            services.AddScoped<ITradeOfferItemGroupRow, Repository.TradeOfferItemGroupRow>();
            services.AddScoped<ITradeOfferSetupRow, Repository.TradeOfferSetupRow>();
            services.AddScoped<ITradeOfferSetupHeader, Repository.TradeOfferSetupHeader>();
            services.AddScoped<IPrice, Repository.Price>();
            services.AddScoped<ITradeOfferConditionTypeItem, Repository.TradeOfferConditionTypeItem>();
            services.AddScoped<ITradeOfferItemGroupHeader, Repository.TradeOfferItemGroupHeader>();
            services.AddScoped<IIncoterms, Repository.Incoterms>();
            services.AddScoped<IBusinessUnitSalesOrganizationIncoterms, Repository.BusinessUnitSalesOrganizationIncoterms>();
            services.AddScoped<ISalesOrderGroup, Repository.SalesOrderGroup>();
            services.AddScoped<ISalesOrderType, Repository.SalesOrderType>();
            services.AddScoped<IOrderReferanceType, Repository.OrderReferanceType>();
            services.AddScoped<IShipPoint, Repository.ShipPoint>();
            services.AddScoped<IShipPointWarehouse, Repository.ShipPointWarehouse>();
            services.AddScoped<ISalesOrderRow, Repository.SalesOrderRow>();
            services.AddScoped<ISalesOffice, Repository.SalesOffice>();
            services.AddScoped<IBusinessPartnerShipPoint, Repository.BusinessPartnerShipPoint>();
            services.AddScoped<ISalesOrderHeader, Repository.SalesOrderHeader>();
            services.AddScoped<IPaymentTerms, Repository.PaymentTerms>();
            services.AddScoped<IDivision, Repository.Division>();
            services.AddScoped<IThana, Repository.Thana>();
            services.AddScoped<IVoucherCode, Repository.VoucherCode>();
            services.AddScoped<IAccountReceivablePayableCommon, Repository.AccountReceivablePayableCommon>();
            services.AddScoped<IVehicle, Repository.Vehicle>();
            services.AddScoped<ITransportMode, Repository.TransportMode>();
            services.AddScoped<ITransportZone, Repository.TransportZone>();
            services.AddScoped<IShippingType, Repository.ShippingType>();
            services.AddScoped<IRoute, Repository.Route>();
            services.AddScoped<IRouteTransportzone, Repository.RouteTransportzone>();
            services.AddScoped<AccountingJournalCodeGenerator>();
            services.AddScoped<IBusinessPartnerZone, Repository.BusinessPartnerZone>();

            #region serilog in elastic search

            var elasticUri = "http://172.17.17.25:8064/";//Configuration["ElasticConfiguration:Uri"];

            Log.Logger = new LoggerConfiguration()
               .Enrich.FromLogContext()
               .Enrich.WithExceptionDetails()
               .Enrich.WithMachineName()
               .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticUri))
               {
                   AutoRegisterTemplate = true,
               })
            .CreateLogger();

            #endregion close

            //Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "iBOS Microservice Service"
                });

                c.EnableAnnotations();
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "Enter the request header in the following box to add Jwt To grant authorization Token: Bearer Token",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference 
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });
        }

        //For Jwt Token Configuration
        private void JwtConfiguration(IServiceCollection services)
        {
            var audienceConfig = Configuration.GetSection("Audience");
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(audienceConfig["Secret"]));
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,
                ValidateIssuer = true,
                ValidIssuer = audienceConfig["Iss"],
                ValidateAudience = true,
                ValidAudience = audienceConfig["Aud"],
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true,
            };

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = "AuthScheme";
            })
            .AddJwtBearer("AuthScheme", x =>
            {
                x.RequireHttpsMetadata = false;
                x.TokenValidationParameters = tokenValidationParameters;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddSerilog();
            app.UseAllElasticApm(Configuration);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();

            //Enable Swagger middleware and endpoint
            app.UseSwagger();

            //Enable middleware to serve swagger - ui(HTML, JS, CSS, etc.), 
            //specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(
                c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Akij InfoTech Ltd"); }
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
