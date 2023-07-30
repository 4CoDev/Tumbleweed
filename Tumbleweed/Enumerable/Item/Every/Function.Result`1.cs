using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Enumerable = Tumbleweed.Enumerable;
using System = System;
using SCG = System.Collections.Generic;
using Item = Tumbleweed.Enumerable.Item;
using Scalar = Tumbleweed.Scalar;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.Item.Every.Function;

public sealed class Result<T> : Enumerable::Envelope<T>
{
	public Result
	(
		params System::Func<T>[] functions
	) : this
	(
		new Enumerable::Concatenated<System::Func<T>>(functions)
	)
	{
	}
	
	public Result
	(
		SCG::IEnumerable<System::Func<T>> functions
	) : base
	(
		new Item::Every.Scalar.Value<T>(
			new Enumerable::Selected<System::Func<T>, Any<T>>(
				functions,
				function => new Actual<T>(function)))
	)
	{
	}
}