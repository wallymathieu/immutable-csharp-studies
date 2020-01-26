# Todos.Apis.TodosApi

All URIs are relative to *https://virtserver.swaggerhub.com/wallymathieu/todos/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTodo**](TodosApi.md#addtodo) | **POST** /api/todos | adds a todo item
[**DeleteTodo**](TodosApi.md#deletetodo) | **DELETE** /api/todos/{id} | delete a todo item
[**SearchInventory**](TodosApi.md#searchinventory) | **GET** /api/todos | searches inventory
[**UpdateTodo**](TodosApi.md#updatetodo) | **PUT** /api/todos/{id} | update a todo item


<a name="addtodo"></a>
# **AddTodo**
> void AddTodo (UpdateTodoItem updateTodoItem = null)

adds a todo item

Adds a todo to the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Todos.Apis;
using Todos.Client;
using Todos.Models;

namespace Example
{
    public class AddTodoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/wallymathieu/todos/1.0.0";
            var apiInstance = new TodosApi(Configuration.Default);
            var updateTodoItem = new UpdateTodoItem(); // UpdateTodoItem | Inventory todo to add (optional) 

            try
            {
                // adds a todo item
                apiInstance.AddTodo(updateTodoItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodosApi.AddTodo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateTodoItem** | [**UpdateTodoItem**](UpdateTodoItem.md)| Inventory todo to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | todo created |  -  |
| **400** | invalid input, object invalid |  -  |
| **409** | an existing todo already exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetodo"></a>
# **DeleteTodo**
> void DeleteTodo (decimal id)

delete a todo item

delete a todo from the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Todos.Apis;
using Todos.Client;
using Todos.Models;

namespace Example
{
    public class DeleteTodoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/wallymathieu/todos/1.0.0";
            var apiInstance = new TodosApi(Configuration.Default);
            var id = 8.14;  // decimal | The todo item id

            try
            {
                // delete a todo item
                apiInstance.DeleteTodo(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodosApi.DeleteTodo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal**| The todo item id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | todo removed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchinventory"></a>
# **SearchInventory**
> List&lt;TodoItem&gt; SearchInventory (string q = null, int? skip = null, int? limit = null)

searches inventory

By passing in the appropriate options, you can search for available inventory in the system 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Todos.Apis;
using Todos.Client;
using Todos.Models;

namespace Example
{
    public class SearchInventoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/wallymathieu/todos/1.0.0";
            var apiInstance = new TodosApi(Configuration.Default);
            var q = q_example;  // string | pass an optional search string for looking up todos (optional) 
            var skip = 56;  // int? | number of records to skip for pagination (optional) 
            var limit = 56;  // int? | maximum number of records to return (optional) 

            try
            {
                // searches inventory
                List<TodoItem> result = apiInstance.SearchInventory(q, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodosApi.SearchInventory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| pass an optional search string for looking up todos | [optional] 
 **skip** | **int?**| number of records to skip for pagination | [optional] 
 **limit** | **int?**| maximum number of records to return | [optional] 

### Return type

[**List&lt;TodoItem&gt;**](TodoItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | search results matching criteria |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetodo"></a>
# **UpdateTodo**
> void UpdateTodo (decimal id, UpdateTodoItem updateTodoItem = null)

update a todo item

Update a todo to the system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Todos.Apis;
using Todos.Client;
using Todos.Models;

namespace Example
{
    public class UpdateTodoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/wallymathieu/todos/1.0.0";
            var apiInstance = new TodosApi(Configuration.Default);
            var id = 8.14;  // decimal | The todo item id
            var updateTodoItem = new UpdateTodoItem(); // UpdateTodoItem | Inventory todo to update (optional) 

            try
            {
                // update a todo item
                apiInstance.UpdateTodo(id, updateTodoItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TodosApi.UpdateTodo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **decimal**| The todo item id | 
 **updateTodoItem** | [**UpdateTodoItem**](UpdateTodoItem.md)| Inventory todo to update | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | todo updated |  -  |
| **400** | invalid input, object invalid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

