using Tumbleweed.Mathematics.Number.Natural;
using Nullable = Tumbleweed.Scalar.Nullable;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.From.Array.At;

public sealed class Index<T> : Nullable::Envelope<T>
{
	public Index
	(
		Array::Any<Nullable::Any<T>> array,
		SCG::IEnumerable<Any> indices
	) : base
	(
		new Nullable::Function.Result<T>(
			() => array[indices].Value)
	)
	{
	}
}