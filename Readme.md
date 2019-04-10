# How to customize Resource headers in SchedulerControl
 
To show custom elements in Resource headers, declare a custom implicit style for a corresponding header visual element and use a custom template in its **Template** property. 
 
Define this style for the **DayResourceHeaderControl** class if you want to customize headers in *DayView*, *WeekView*, and *WorkWeekView*. Define it for **MonthResourceHeaderControl** to change these headers in *MonthView*. 
 
In your custom template, you can bind elements directly to properties from your Resource data items. The *DayResourceHeaderControl* and *MonthResourceHeaderControl* classes contain such an object in their **Resource.SourceObject.SourceObject** property. 

````xaml
<ControlTemplate x:Key="CustomHeaderTemplate" TargetType="dxschi:ResourceHeaderControlBase">
    <Grid BorderThickness="{TemplateBinding BorderThickness}"
                        BorderBrush="{TemplateBinding BorderBrush}"
                        Padding="0,10,0,0">
        <StackPanel Orientation="Vertical" Margin="12,0,0,10"  >
            <Image  Height="100" Width="100"
                    Source="{Binding Resource.SourceObject.SourceObject.ResourceImage, RelativeSource={RelativeSource Mode=TemplatedParent}}"
                    HorizontalAlignment="Center"/>
            <TextBlock  Text="{Binding  Resource.Caption, RelativeSource={RelativeSource Mode=TemplatedParent}}" 
                        Foreground="{Binding Resource.Style.Brush, RelativeSource={RelativeSource Mode=TemplatedParent}}"
                        HorizontalAlignment="Center"
                        FontSize="16"
                        FontWeight="SemiBold"
                        Margin="3,10"/>
        </StackPanel>
        <Rectangle Fill="{Binding Resource.Style.Brush, RelativeSource={RelativeSource Mode=TemplatedParent}}" 
                    Height="4" 
                    VerticalAlignment="Bottom" 
                    HorizontalAlignment="Stretch"/>
    </Grid>
</ControlTemplate>

<Style TargetType="dxschi:DayResourceHeaderControl">
    <Setter Property="Template" Value="{StaticResource CustomHeaderTemplate}"/>
</Style>
<Style TargetType="dxschi:MonthResourceHeaderControl">
    <Setter Property="Template" Value="{StaticResource CustomHeaderTemplate}"/>
</Style>
 ````
