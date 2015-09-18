using System;
using System.Net;
using System.Net.Http;
using System.Collections;
using System.Collections.Generic;
using System.Json;
using Newtonsoft.Json;

namespace EmployeeDirectory
{
	public class EmployeeDirectoryClientWS
	{
		public EmployeeDirectoryClientWS ()
		{
			// /employees/_design/employeeDesignDoc/_search/lastname?q=lastname:' + empName + '&include_docs=true
			// /employees/_design/employeeDesignDoc/_view/last?include_docs=true
			// srhallx.cloudant.com: 443

		}

		public async List<Employee> GetAllEmployees()
		{
			var client = new HttpClient ();
			var employeeData = await client.GetStringAsync ("https://srhallx.cloudant.com:443/employees/_design/employeeDesignDoc/_view/last?include_docs=true");

			return ParseEmployeeResultSet (employeeData);

		}

		protected Employee[] ParseEmployeeResultSet(string data)
		{

			Employee[] emp = new Employee[data["resultSet"].Count];
			emp = JsonConvert.DeserializeObject<Employee[]> (obj ["resultSet"].ToString ());

			return emp;
		}

		protected Employee ParseSingleEmployeeResult(JsonObject obj)
		{
			Employee emp = JsonConvert.DeserializeObject<Employee> (obj.ToString ());
			return emp;
		}
	}
}

