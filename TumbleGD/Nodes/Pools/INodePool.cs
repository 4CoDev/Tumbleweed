using Tumbleweed.Delegates.Events.Nullary;

namespace TumbleGD.Nodes.Pools;

public interface INodePool
{
	INullaryEvent Graphicals { get; }
	
	INullaryEvent Physicals { get; }
	
	INullaryEvent Inputs { get; }
}