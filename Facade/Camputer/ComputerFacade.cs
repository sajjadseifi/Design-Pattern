namespace Design_Pattern.Facade.Camputer
{
    public class ComputerFacade
    {
        private readonly CPU _proccessor;
        private readonly Memory _ram;
        private readonly HardDrive _hd;

        public ComputerFacade()
        {
            _proccessor = new CPU();
            _hd = new HardDrive();
            _ram = new Memory();
        }

        public void start()
        {
            _proccessor.freeze();
            _ram.load(Constant.BOOT_ADDRESS, _hd.read(Constant.BOOT_SECTOR, Constant.SECTOR_SIZE));
            _proccessor.jump(Constant.BOOT_ADDRESS);
            _proccessor.execute();
        }
    }
}