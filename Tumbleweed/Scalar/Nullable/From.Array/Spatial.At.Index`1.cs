using Nullable = Tumbleweed.Scalar.Nullable;
using Array = Tumbleweed.Array;
using Point = Tumbleweed.Point.Spatial;
using Natural = Tumbleweed.Number.Natural;
using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.From.Array.Spatial.At;

public sealed class Index<T> : Nullable::Envelope<T>
{
	public Index
	(
		Array::Any<Nullable::Any<T>> array,
		Point::Any<Natural::Any> indices
	) : base
	(
		new Nullable::Scalar.Value.One<T>(
			new Immutable::From.Array.Spatial.At.Index
				<Nullable::Any<T>>
				(array, indices))
	)
	{
	}
}