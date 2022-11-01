# Phantasma RPC Client

C# client to interact via RCP with an Phantasma node.

## Sample code
```c#
	var rpcURl = @"http://localhost:5101/";
	var client = new ApiClient(rpcURl);
	var accountAPI = new AccountApi(client);
	var address = "P2K56BVqGndVhEmyaX9CVcqGHGkAfKUgeTnK1LfDjddqFPn";
	var account = accountAPI.ApiV1GetAccountGet(address);
```


