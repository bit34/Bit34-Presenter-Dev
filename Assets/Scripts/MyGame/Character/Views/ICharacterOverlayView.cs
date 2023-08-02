namespace MyGame.Character.Views
{
    public interface ICharacterOverlayView
    {
        //  METHODS
        void Initialize();
        void SetCharacter(string name);
        void ClearCharacter();
    }
}
