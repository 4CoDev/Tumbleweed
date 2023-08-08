using DotGod.Node.Spatial.Batch;
using DotGod.Node.Spatial.Batch.Entities;
using DotGod.Node.Spatial.Batch.Space;
using Tumbleweed.Array;

namespace DotGod.Node.Spatial.Spaced.Batch.Of;

public sealed class Scalar : Abstract.IBatch
{
	public Scalar(Tumbleweed.Scalar.Immutable.Any<Abstract.IBatch> any) =>
		this.any = any;

	public Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches =>
		any.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		any.Value.Entities;

	public ISpace Space =>
		any.Value.Space;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Abstract.IBatch> any;
}