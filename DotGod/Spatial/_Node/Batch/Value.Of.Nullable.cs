using Tumbleweed.Nullable;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Value.Of;

public sealed class Nullable : Batch.Envelope
{
	public Nullable(Any<Batch.Any> any) : base
	(
		new Value.Of.Scalar(
			new Value<Batch.Any>(any))
	)
	{
	}
}