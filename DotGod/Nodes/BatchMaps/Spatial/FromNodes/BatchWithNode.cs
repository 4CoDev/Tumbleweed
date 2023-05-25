using DotGod.Nodes.BatchMaps.Spatial.Batches;
using DotGod.Nodes.BatchMaps.Spatial.Entities;
using Godot;
using DotGod.Nodes.BatchMaps.Spatial.Entities.FromNodes;
using Tumbleweed.Arrays;
using Tumbleweed.Nullables;
using Tumbleweed.Scalars;
using EntitiesOfBatch = DotGod.Nodes.BatchMaps.Spatial.Entities.FromNodes.EntitiesOfBatch;

namespace DotGod.Nodes.BatchMaps.Spatial.FromNodes;

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