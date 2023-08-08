using DotGod.Node.Spatial.Batch;
using DotGod.Node.Spatial.Batch.Entities;
using Tumbleweed.Array;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Value.Of;

public sealed class Scalar : Any
{
	public Scalar(Tumbleweed.Scalar.Immutable.Any<Any> scalar) =>
		this.scalar = scalar;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		scalar.Value.Entities;

	private readonly Tumbleweed.Scalar.Immutable.Any<Any> scalar;
}