using DotGod.Node.Spatial.Batch;
using Tumbleweed.Scalar.Nullable;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Value.Of;

public sealed class Nullable : Envelope
{
	public Nullable(Any<Any> any) : base
	(
		new Value.Of.Scalar(any)
	)
	{
	}
}