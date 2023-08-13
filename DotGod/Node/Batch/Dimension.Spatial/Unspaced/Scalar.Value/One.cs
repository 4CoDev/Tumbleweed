namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced.Scalar.Value;

public sealed class One : Any
{
	public One(Tumbleweed.Scalar.Immutable.Any<Any> scalar) =>
		this.scalar = scalar;

	public Tumbleweed.Array.Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<Entity.Any> Entities =>
		scalar.Value.Entities;

	private readonly Tumbleweed.Scalar.Immutable.Any<Any> scalar;
}