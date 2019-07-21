// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="TimelogBusiness.cs" company="">Copyright (c) companyname . All rights reserved.</copyright>
// <author></author>
// <createdOn></createdOn>
// <comment></comment>
// ---------------------------------------------------------------------------------------------------------------------
namespace UtilizationTracker.Controllers.Timelog
{
    
    #region Namespace
    using System.Web.Http;
    using UtilizationTracker.Business.IBusiness;
    using System.Net;
    #endregion
    /// <summary>
    /// 
    /// </summary>
    public class TimelogController : ApiController
    {
        
        #region Variable Declaration 
        /// <summary>
        /// 
        /// </summary>
        public readonly ITimelogBusiness _ITimelogBusiness;
        #endregion

        #region Constructor
        /// <summary>
        /// Parameterized constructor. 
        /// </summary>
        /// <param name="_itimelogBusiness"></param>
        public TimelogController(ITimelogBusiness _itimelogBusiness)
        {
            _ITimelogBusiness = _itimelogBusiness;  
        }
        #endregion

        #region Get
        [HttpGet]
        public IHttpActionResult Get()
        {
            int val = this._ITimelogBusiness.Get();
            if (val > 0)
                return this.Content(HttpStatusCode.OK, "");
            else
                return this.Content(HttpStatusCode.NotFound, "");
                        
        }
        #endregion
    }
}
