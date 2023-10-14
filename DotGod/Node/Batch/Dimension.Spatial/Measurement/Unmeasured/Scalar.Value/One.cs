using Tumbleweed.Array.Dimension.Multi;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Scalar.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Any> scalar) =>
		this.scalar = scalar;

	public Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<Entity.Any> Entities =>
		scalar.Value.Entities;

	private readonly Tumbleweed.Scalar.Immutable.Any<Any> scalar;
}