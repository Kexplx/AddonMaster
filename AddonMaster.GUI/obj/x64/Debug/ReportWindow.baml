   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI"   AddonMaster.GUI.ReportWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   -   5        
�������$��1q�5
      (   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  �����   ShowCloseButton .   � 
ResizeMode$ NoResize=�5   K      ShowMinButton .   � SizeToContent$ WidthAndHeight=�5   -   
������� � WindowStartupLocation$ CenterOwner=�5         ShowTitleBar .  .��5      � $	��200��6   $	��370��6   
�������.+�5   
   �� $��0,1,0,1q�6   
�������$��	0,33,0,26q�6B   ._�5      �� -   5         ��Name$ 
txtContent��5   ~   �� AcceptsReturn . 	 �� 
CaretBrush
	 �   �
���iii�
 �� 	MaxLength$

 1000��6S    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�    J� Opacity$ 1Q�6  $	��370��6  
������ $��0q�64  $��Center=�6H  $
��Left=�6c  $��0q�6�  $	��140��6�  ��6d   �� *OutlinePlain+ �� Mode$ TwoWay=� �� NotifyOnTargetUpdated . 6�  5      �� 5   
    J� IsHitTestVisible .  $��20(�6-   $��Leave your Feedback��6;   $��Center=�6V   $
��Left=�6q   $��
84,86,0,86q�6�   
�������$	��203��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 5      �� 5       �� Binding 6&   �� *Text+ �� ElementName$ 
txtContent�� �� Value  6W   .a�5      ��  � y�$ Visible=�6;   5      �� 5       6&   �� *IsKeyboardFocused+$ 
txtContent�� true6d   .a�5      ��  � y�$ 	Collapsed=�6;   5      5      5       �� 5!   
   -   5        $��checkboxBug��5!      $��
Bug Report��6D   
�������
���iii�$
��Left=�6�   $��0,10,0,0q�6�   $	��Top=�6�   �� 5"   
   -   5        $��checkboxFeedback��5"      $��Feedback��6+   
�������
���iii�$
��Left=�6�   $��	84,10,0,0q�6�   $	��Top=�6�   "  FontAwesome.WPF.ImageAwesome  5#   
   -   5          Name$ imgSend��5#   9    � Cursor$
 Hand��6   {�.  � ToolTip$ Send the Feedback��6J   $	 0.8Q�6�      Icon$
 Send=�6�   $��340,172,9,-1q�6�      
Foreground
 ���F�6�     5$   
   -   5        $��spinner��5$   %   $	 Cog=�6      Spin . $y�	Collapsed=�6@   
 �����$	 0.8Q�6n      SpinDuration$ 2Q�6|   $��307,174,30,4q�6�     5%   
   -   5        $ TimesCircle=�5%      $ Close��6-   $	 0.8Q�6=   $
 Hand��6K   $��340,5,5,170q�6|   
 ����� J� RenderTransformOrigin$ 0.5,0.5&�6�     5&   
   -   5        $ MinusCircle=�5&      $ Minimize��6-   $	 0.8Q�6@   $
 Hand��6N   $��310,5,35,170q�6   
 �����$ 0.5,0.5&�6�     5'   
   -	   5        $ QuestionCircle=�5'      $
 Help��60   $	 0.8Q�6?   $
 Hand��6M   $��280,5,65,170q�6~   
 �����$ 0.5,0.5&�6�   5(      5)      