using DotGod.Node.Batch.Dimension.Spatial.Entity;
using Tumbleweed.Collection;
using Tumbleweed.Collection.Function.Result;

namespace DotGod.Node.Batch.Dimension.Spatial.Member.Entity.Collection;

public sealed class One : Envelope<Any>
{
	public One(Measurement.Unmeasured.Any batch) : base
	(
		new Actual<Any>(
			() => batch.Entities)
	)
	{
	}

}