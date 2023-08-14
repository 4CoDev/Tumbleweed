using Iteration = DotGod.Engine.Iteration;
using Input = DotGod.Engine.Input;

namespace DotGod.Engine.Event.Group;

public interface Any
{
	Iteration::Event.Group.Any Iteration { get; }
	
	Input::Event.Group.Any Input { get; }
}