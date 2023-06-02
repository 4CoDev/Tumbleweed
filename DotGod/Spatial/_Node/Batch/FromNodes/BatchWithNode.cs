using DotGod.Spatial._Node.Batch.Entities;
using Godot;
using Tumbleweed.Array;
using Tumbleweed.Nullable;
using Tumbleweed.Scalar;
using EntitiesOfBatch = DotGod.Spatial._Node.Batch.Entities.FromNodes.EntitiesOfBatch;

namespace DotGod.Spatial._Node.Batch.FromNodes;

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