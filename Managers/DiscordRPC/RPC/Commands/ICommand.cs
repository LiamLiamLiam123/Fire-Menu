using Fire.Managers.DiscordRPC.RPC.Payload;

namespace Fire.Managers.DiscordRPC.RPC.Commands
{
    internal interface ICommand
    {
        IPayload PreparePayload(long nonce);
    }
}
