using Godot;
using TumbleGD.Nodes.BatchMaps.Spatial.Batches;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities.FromNodes;
using Tumbleweed.Arrays;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;
using EntitiesOfBatch = TumbleGD.Nodes.BatchMaps.Spatial.Entities.FromNodes.EntitiesOfBatch;

namespace TumbleGD.Nodes.BatchMaps.Spatial.FromNodes;

public sealed class BatchWithNode : ISpatialBatch
{
	public BatchWithNode(IScalar<Node3D> node) =>
		this.node = node;

	public INullable<IArray<ISpatialBatch>> Subbatches =>
		new SubbatchesOfNode(node);

	public ICollection<ISpatialEntity> Entities =>
		new EntitiesOfBatch(node);

	private readonly IScalar<Node3D> node;
}