	//----------IdentityUser开始----------

using SqlSugar;    
using System;
namespace CoreT.Entity
{	
	/// <summary>
	/// IdentityUser
	/// </summary>	
	public class IdentityUser//可以在这里加上基类等
	{
	//将该表下的字段都遍历出来，可以自定义获取数据描述等信息
    	     
	   [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] //是主键, 还是标识列 
	    
	  public int  Id { get; set; }
	     
	  public string  Name { get; set; }
	     
	  public string  Account { get; set; }
	     
	  public string  Password { get; set; }
	     
	  public int  RoleId { get; set; }
	     
	  public string  Email { get; set; }
 
}
}
	//----------IdentityUser结束----------
	