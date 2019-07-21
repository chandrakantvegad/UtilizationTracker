namespace UtilizationTracker.Business
{
    #region Namespace
    using System;
    using System.Web.Http;
    using Microsoft.Practices.Unity;
    using Unity.WebApi;
    using UtilizationTracker.Business.Business;
    using UtilizationTracker.Business.IBusiness;
    using UtilizationTracker.Repository.IRepository;
    using UtilizationTracker.Repository.Repository;
    #endregion

    /// <summary>
    /// Register all your components here
    /// </summary>
    public class UnitySettings
    {
        /// <summary>
        /// Register Parameter with Method
        /// </summary>
        /// <param name="config">config is object of HttpConfiguration</param>
        public static void RegisterComponents(HttpConfiguration config)
        {
            try
            {
                //register all your components with the container here
                var container = new UnityContainer();

                container.RegisterType<ITimelogBusiness, TimelogBusiness>(new HierarchicalLifetimeManager());
                container.RegisterType<ITimelogRepository, TimelogRepository>(new HierarchicalLifetimeManager());

                config.DependencyResolver = new UnityDependencyResolver(container);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}