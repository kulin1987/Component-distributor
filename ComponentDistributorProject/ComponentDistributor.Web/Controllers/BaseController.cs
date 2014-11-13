namespace ComponentDistributor.Web.Controllers
{    
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using ComponentDistributor.Data.Contracts.Repository;

    public class BaseController : Controller
    {
        public BaseController(IDataProvider data)
        {
            this.Data = data;
        }

        public IDataProvider Data { get; set; }
    }
}