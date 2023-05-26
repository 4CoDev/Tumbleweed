using DotGod._Node.BatchMap.Spatial.Batches;
using DotGod._Node.BatchMap.Spatial.Entities;
using Godot;
using Tumbleweed.Array;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;
using EntitiesOfBatch = DotGod._Node.BatchMap.Spatial.Entities.FromNodes.EntitiesOfBatch;

namespace DotGod._Node.BatchMap.Spatial.FromNodes;

public sealed class BatchWithNode : IBatch
{
	public BatchWithNode(IScalar<Node3D> node) =>
		this.node = node;

	public INullable<IArray<IBatch>> Subbatches =>
		new SubbatchesOfNode(node);

	public ICollection<ISpatialEntity> Entities =>
		new EntitiesOfBatch(node);

	private readonly IScalar<Node3D> node;
}