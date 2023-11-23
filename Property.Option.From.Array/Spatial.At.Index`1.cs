using Option = Tumbleweed.Property.Option;
using Array = Tumbleweed.Array;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Output = Tumbleweed.Property.Output;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Option.From.Array.Spatial.At;

public sealed class Index<T> : Option::Envelope<T>
{
	public Index
	(
		Array::Dimension.Multi.Any<Option::Any<T>> array,
		Mathematics.Vector.Spatial.Generic.Any<Natural::Any> indices
	) : base
	(
		new Option::Output.Value.Actual<T>(
			new Output::From.Array.Spatial.At.Index
				<Option::Any<T>>
				(array, indices))
	)
	{
	}
}