using Tumbleweed.Mathematics.Number.Natural;
using Nullable = Tumbleweed.Property.Nullable;
using Array = Tumbleweed.Array;

using Natural = Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.From.Array.Spatial.At;

public sealed class Index<T> : Nullable::Envelope<T>
{
	public Index
	(Tumbleweed.Array.Dimension.Multi.Any<Nullable::Any<T>> array, Mathematics.Vector.Spatial.Generic.Any<Any> indices
	) : base
	(
		new Nullable::Property.Value.One<T>(
			new Property::From.Array.Spatial.At.Index
				<Nullable::Any<T>>
				(array, indices))
	)
	{
	}
}