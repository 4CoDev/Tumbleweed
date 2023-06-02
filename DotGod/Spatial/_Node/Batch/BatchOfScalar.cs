using DotGod.Spatial._Node.Batch.Entities;
using Tumbleweed.Array;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch;

public sealed class BatchOfScalar : IBatch
{
	public BatchOfScalar(IScalar<IBatch> scalar) =>
		this.scalar = scalar;

	public INullable<IArray<IBatch>> Subbatches =>
		scalar.Value.Subbatches;

	public ICollection<ISpatialEntity> Entities =>
		scalar.Value.Entities;

	private readonly IScalar<IBatch> scalar;
}