﻿#region License
// Copyright (c) Newtonsoft. All Rights Reserved.
// License: https://raw.github.com/JamesNK/Newtonsoft.Json.Schema/master/LICENSE.md
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Schema.Generation;
using NUnit.Framework;

namespace Newtonsoft.Json.Schema.Tests.Documentation.Samples.Generation
{
    [TestFixture]
    public class GenerateSchema : TestFixtureBase
    {
        #region Types
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        #endregion

        [Test]
        public void Example()
        {
            #region Usage
            JSchemaGenerator generator = new JSchemaGenerator();

            JSchema schema = generator.Generate(typeof(Person));
            // {
            //   "type": "object",
            //   "properties": {
            //     "Name": {
            //       "type": [ "string", "null" ]
            //     },
            //     "Age": { "type": "integer" }
            //   },
            //   "required": [ "Name", "Age" ]
            // }
            #endregion

            Assert.AreEqual(JSchemaType.Object, schema.Type);
        }
    }
}