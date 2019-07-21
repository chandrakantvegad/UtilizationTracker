// ---------------------------------------------------------------------------------------------------------------------
// <copyright file="ITimelogBusiness.cs" company="">Copyright (c) companyname . All rights reserved.</copyright>
// <author></author>
// <createdOn></createdOn>
// <comment></comment>
// ---------------------------------------------------------------------------------------------------------------------
namespace UtilizationTracker.Business.Business
{
    #region Namespace
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UtilizationTracker.Business.IBusiness;
    using UtilizationTracker.Repository.IRepository;
    #endregion
    /// <summary>
    /// 
    /// </summary>
    public class TimelogBusiness : ITimelogBusiness
    {
        
        #region VariableDeclaration
        /// <summary>
        /// 
        /// </summary>
        private readonly ITimelogRepository _ITimelogRepository;
        #endregion

        #region Constructor
        /// <summary>
        ///Parameterized constructor. 
        /// </summary>
        /// <param name="_itimelogRepository"></param>
        public TimelogBusiness(ITimelogRepository _itimelogRepository)
        {
            _ITimelogRepository = _itimelogRepository;
        }
        #endregion

        /// <summary>
        ///  Get time log
        /// </summary>
        public int Get()
        {
            return this._ITimelogRepository.Get();
        }
    }
}
