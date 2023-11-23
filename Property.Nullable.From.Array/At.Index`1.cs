using Tumbleweed.Mathematics.Number.Natural;
using Nullable = Tumbleweed.Property.Nullable;
using Array = Tumbleweed.Array;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.From.Array.At;

public sealed class Index<T> : Nullable::Envelope<T>
{
	public Index
	(
		Tumbleweed.Array.Dimension.Multi.Any<Nullable::Any<T>> array,
		SCG::IEnumerable<Any> indices
	) : base
	(
		new Nullable::Function.Actual<T>(
			() => array[indices].Value)
	)
	{
	}
}