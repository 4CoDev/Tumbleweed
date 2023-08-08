using DotGod.Node.Spatial.Batch.Entities;
using Godot;
using Tumbleweed.Array;
using EntitiesOfBatch = DotGod.Node.Spatial.Batch.Entities.FromNodes.EntitiesOfBatch;

namespace DotGod.Node.Spatial.Batch.FromNodes;

public sealed class BatchWithNode : Any
{
	public BatchWithNode(Tumbleweed.Scalar.Immutable.Any<Node3D> node) =>
		this.node = node;

	public Any<Tumbleweed.Scalar.Nullable.Any<Any>> Subbatches =>
		new SubbatchesOfNode(node);

	public ICollection<ISpatialEntity> Entities =>
		new EntitiesOfBatch(node);

	private readonly Tumbleweed.Scalar.Immutable.Any<Node3D> node;
}