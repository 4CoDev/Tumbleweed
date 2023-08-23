using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;
using EmptyArray = Tumbleweed.Array.Dimension.Spatial.Filling.New.Snapshot.Filler.Null.Object;
using Entity = DotGod.Node.Batch.Dimension.Spatial.Entity;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Empty;

public sealed class One : Batch::Envelope
{
	public One() : base
	(
		new Batch::With.Members.One(
			new EmptyArray::With.Size.System<Batch::Any>(
				new Batch::Subbatch.Array.Size.System()),
			new List<Entity::Any>())
	)
	{
	}
}