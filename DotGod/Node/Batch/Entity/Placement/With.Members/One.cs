using Placement = DotGod.Node.Batch.Entity.Placement;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Node.Batch.Entity.Placement.With.Members;

public sealed class One : Placement::Any
{
	public One
	(
		Procedure::Any place,
		Procedure::Any remove
	)
	{
		this.place = place;
		this.remove = remove;
	}
	
	public void Place() =>
		place.Invoke();

	public void Remove() =>
	 remove.Invoke();
	
	private readonly Procedure::Any place;
	
	private readonly Procedure::Any remove;
}