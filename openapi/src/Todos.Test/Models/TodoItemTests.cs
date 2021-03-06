/* 
 * Todo MVC backend style API
 *
 * This is a simple API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Todos.Apis;
using Todos.Models;
using Todos.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Todos.Test
{

    /// <summary>
    ///  Class for testing TodoItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TodoItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TodoItem
        //private TodoItem instance;

        public TodoItemTests()
        {
            // TODO uncomment below to create an instance of TodoItem
            //instance = new TodoItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        [Fact]
        public void Deserialize_json()
        {
            var json = @"{""id"":1,""text"":""text""}";
            var res=JsonConvert.DeserializeObject<TodoItem>(json, TestHelpers.SerializerSettings);
            Assert.Equal(1, res.Id);
            Assert.Equal("text", res.Text);
        }
        [Fact]
        public void Serialize_json()
        {
            var json = @"{""id"":1.0,""text"":""Text""}";
            var res = JsonConvert.SerializeObject(new TodoItem(text:"Text",id:1), TestHelpers.SerializerSettings);
            Assert.Equal(json, res);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }

    }

}
