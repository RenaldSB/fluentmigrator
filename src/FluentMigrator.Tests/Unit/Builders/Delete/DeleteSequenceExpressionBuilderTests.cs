#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using FluentMigrator.Builders.Delete.Column;
using FluentMigrator.Expressions;
using Moq;
using NUnit.Framework;

namespace FluentMigrator.Tests.Unit.Builders.Delete
{
    using FluentMigrator.Builders.Delete.Sequence;

    [TestFixture]
	public class DeleteSequenceExpressionBuilderTests
	{
		[Test]
		public void CallingInSchemaSetsInSchema()
		{
			var expressionMock = new Mock<DeleteSequenceExpression>();
            expressionMock.SetupSet(x => x.SchemaName = "Bacon");

            var builder = new DeleteSequenceExpressionBuilder(expressionMock.Object);
			builder.InSchema("Bacon");

			expressionMock.VerifyAll();
		}
	}
}