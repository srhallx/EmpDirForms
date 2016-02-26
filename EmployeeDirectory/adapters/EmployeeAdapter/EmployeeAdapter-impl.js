
function allEmployees() {
	var input = {
		method : 'get',
		returnedContentType : 'json',
		path : '/employees/_design/employeeDesignDoc/_view/last?include_docs=true'
	};

	var response = WL.Server.invokeHttp(input);

	if (response.statusCode == 200)
	{
		myresp = [];
		for (var i = 0; i < response.rows.length; ++i)
			myresp[i] = response.rows[i].doc;

		return { "resultSet" : myresp };
	}
	
	return [{"isSuccessful":"false"}];
}

function findEmployee(empName) {

	var input = {
		method : 'get',
		returnedContentType : 'json',
		path : '/employees/_design/employeeDesignDoc/_search/lastname?q=lastname:' + empName + '&include_docs=true'
	};
	
	var response = WL.Server.invokeHttp(input);

	if (response.statusCode == 200)
	{
		return response.rows[0].doc;
	}
	
	return [{"isSuccessful":"false"}];

}

