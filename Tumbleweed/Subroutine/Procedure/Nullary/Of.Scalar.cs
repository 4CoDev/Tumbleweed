using Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Nullary.Of;

public sealed class Scalar : Nullary.Any
{
	public Scalar(Any<Nullary.Any> action) =>
		this.action = action;
	
	public void Invoke() =>
		action.Value.Invoke();
	
	private readonly Any<Nullary.Any> action;
}