using DotGod.Node.Batch.Dimension.Spatial.Entity;
using Tumbleweed.Collection;

namespace DotGod.Node.Batch.Dimension.Spatial.Member.Entity.Collection;

public sealed class One : CollectionEnvelope<Any>
{
	public One(Measurement.Unmeasured.Any batch) : base
	(
		new CollectionOfFunction<Any>(
			() => batch.Entities)
	)
	{
	}

}