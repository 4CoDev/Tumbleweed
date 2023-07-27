using DotGod.Spatial._Node.Batch.Entities;
using Godot;
using Tumbleweed.Array;
using EntitiesOfBatch = DotGod.Spatial._Node.Batch.Entities.FromNodes.EntitiesOfBatch;

namespace DotGod.Spatial._Node.Batch.FromNodes;

public sealed class BatchWithNode : Any
{
	public BatchWithNode(Tumbleweed.Scalar.Any<Node3D> node) =>
		this.node = node;

	public Any<Tumbleweed.Nullable.Any<Any>> Subbatches =>
		new SubbatchesOfNode(node);

	public ICollection<ISpatialEntity> Entities =>
		new EntitiesOfBatch(node);

	private readonly Tumbleweed.Scalar.Any<Node3D> node;
}