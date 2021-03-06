using Ryujinx.HLE.HOS.Services.Hid;

namespace Ryujinx.HLE.HOS.Tamper
{
    interface ITamperProgram
    {
        string Name { get; }
        bool TampersCodeMemory { get; set; }
        ITamperedProcess Process { get; }
        void Execute(ControllerKeys pressedKeys);
    }
}
