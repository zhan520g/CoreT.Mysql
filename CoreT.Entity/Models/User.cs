	//----------User开始----------

using SqlSugar;    
using System;
namespace CoreT.Entity
{	
	/// <summary>
	/// User
	/// </summary>	
	public class User//可以在这里加上基类等
	{
	//将该表下的字段都遍历出来，可以自定义获取数据描述等信息
    	     
	   [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] //是主键, 还是标识列 
	    
	  public int  id { get; set; }
	     
	  public string  name { get; set; }
 
}
}
	//----------User结束----------
	