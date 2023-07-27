using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;

// ReSharper disable once CheckNamespace
namespace DotGod.Spatial._Node.Batch.Value.Of;

public sealed class Scalar : Batch.Any
{
	public Scalar(Tumbleweed.Scalar.Any<Batch.Any> scalar) =>
		this.scalar = scalar;

	public Tumbleweed.Array.Any<Tumbleweed.Nullable.Any<Batch.Any>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		scalar.Value.Entities;

	private readonly Tumbleweed.Scalar.Any<Batch.Any> scalar;
}