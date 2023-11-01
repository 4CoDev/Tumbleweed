using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.Function;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Node;

public sealed class One : Envelope<Godot.Node>
{
	public One(Any entity) : base
	(
		new Result<Godot.Node>(
			() => entity.Node)
	)
	{
	}
}