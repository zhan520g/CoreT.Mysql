
	//----------User开始----------
    

using System;
using CoreT.IServices;
using CoreT.IRepository;
using CoreT.Entity;

namespace CoreT.Services
{	
	/// <summary>
	/// UserServices
	/// </summary>	
	public class UserServices : BaseServices<User>, IUserServices
    {
        IUserRepository dal;
        public UserServices(IUserRepository dal)
        {
            this.dal = dal;
            base.BaseDal = dal;
        }
    }
}

	//----------User结束----------
	