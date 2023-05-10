using DotGod.Nodes.BatchMaps.Spatial.Entities;
using Tumbleweed.Arrays;
using Tumbleweed.Nullables;
using Tumbleweed.Scalars;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

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