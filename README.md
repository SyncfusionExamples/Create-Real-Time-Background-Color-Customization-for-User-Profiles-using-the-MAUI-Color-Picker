# Create-Real-Time-Background-Color-Customization-for-User-Profiles-using-the-MAUI-Color-Picker

This sample demonstrates how to implement real-time background color customization for user profiles using the MAUI Color Picker in a .NET MAUI application.

## Sample

```xaml
    <Grid RowDefinitions="Auto,*" Margin="80">

        <sfavatar:SfAvatarView x:Name="avatar" Grid.Row="0" VerticalOptions="Center"
                            HorizontalOptions="Center" ContentType="AvatarCharacter"
                            AvatarCharacter="Avatar29" Background="DeepSkyBlue"
                            WidthRequest="120" HeightRequest="120" CornerRadius="60"
                            Stroke="Black" StrokeThickness="1">
        </sfavatar:SfAvatarView>

        <inputs:SfColorPicker x:Name="colorPicker" Grid.Row="1" PaletteCellShape="Circle" IsInline="True"  
                            ShowRecentColors="False" ShowNoColor="False" IsColorModeSwitcherVisible="False"
                            ColorMode="Palette" ShowInputArea="False" PaletteColumnSpacing="5" PaletteRowSpacing="5"
                            PaletteColumnCount="5" PaletteRowCount="2" ColorChanged="PaletteColorChanged"
                            HorizontalOptions="Center" VerticalOptions="Center"/>

    </Grid>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples
