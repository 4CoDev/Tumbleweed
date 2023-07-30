using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Array;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Value.Of;

public sealed class Scalar : Batch.Any
{
	public Scalar(Tumbleweed.Scalar.Immutable.Any<Batch.Any> scalar) =>
		this.scalar = scalar;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Batch.Any>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		scalar.Value.Entities;

	private readonly Tumbleweed.Scalar.Immutable.Any<Batch.Any> scalar;
}