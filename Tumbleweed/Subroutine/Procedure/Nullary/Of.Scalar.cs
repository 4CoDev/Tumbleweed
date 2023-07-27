// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Nullary.Of;

public sealed class Scalar : Nullary.Any
{
	public Scalar(Tumbleweed.Scalar.Any<Nullary.Any> action) =>
		this.action = action;
	
	public void Invoke() =>
		action.Value.Invoke();
	
	private readonly Tumbleweed.Scalar.Any<Nullary.Any> action;
}