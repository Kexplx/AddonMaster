   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI"   AddonMaster.GUI.ReportWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   Jcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   -   5        
�������$��1q�5
      (   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  �����   ShowCloseButton .   � 
ResizeMode$ NoResize=�5   K      ShowMinButton .   � SizeToContent$ WidthAndHeight=�5   -   
������� � WindowStartupLocation$ CenterOwner=�5         ShowTitleBar .  .��5      � $	��200��6   $	��370��6   
�������.+�5   
   �� $��0,1,0,1q�6   
�������$��	0,31,0,26q�6B   ._�5      �� -   5         ��Name$ 
TxtContent��5   Z   �� AcceptsReturn . 	 �� 
CaretBrush
	 �   �
���iii�
 �� 	MaxLength$

 1000��6S    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�    J� Opacity$ 1Q�6�   $	��370��6�   
������ $��0q�6  $��Center=�6$  $
��Left=�6?  $��0,0,0,1q�6n  $	��140��6  ��6d   �� *OutlinePlain+ �� Mode$ TwoWay=� �� NotifyOnTargetUpdated . 6  5      �� 5   
    J� IsHitTestVisible .  $��20(�6-   $��Leave your Feedback��6;   $��Center=�6V   $
��Left=�6q   $��
84,86,0,86q�6�   
�������$	��203��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 5      �� 5       �� Binding 6&   �� *Text+ �� ElementName$ 
TxtContent�� �� Value  6W   .a�5      ��  � y�$ Visible=�6;   5      �� 5       6&   �� *IsKeyboardFocused+$ 
TxtContent�� true6d   .a�5      ��  � y�$ 	Collapsed=�6;   5      5      5       �� 5!   
   -   5        $��CheckboxBug��5!      $��
Bug Report��6&   
�������
���iii�$
��Left=�6c   $��	2,177,0,0q�6~   $	��Top=�6�   ��5"      �� 5#      " ��6   .�5$      ��  �@d�	IsChecked$
 TrueY�62    5%      �� 5&       6&   �� *	IsChecked+$ CheckboxFeedback�� true6b   .a�5'      ��  �@d�	IsChecked$ FalseY�6:   6J   5(      5*      5,      �� 5-   
   -   5        $��CheckboxFeedback��5-      $��Feedback��6+   
�������
���iii�$
��Left=�6f   $��
86,177,0,0q�6�   $	��Top=�6�   ��5.      �� 5/      " ��6   .�50      ��  �@d�	IsChecked$ FalseY�62    51      �� 52       6&   �� *	IsChecked+$ CheckboxBug��	 False6]   .a�53      ��  �@d�	IsChecked$
 TrueY�6:   6I   54      56      58      "  FontAwesome.WPF.ImageAwesome  59   
   -   5          Name$ ImgSend��59   (    � Cursor$
 Hand��6    � ToolTip$ Send the Feedback��69      Icon$
 Send=�6t   $��340,172,9,-1q�6�      
Foreground
 ���F���5:      �� 5;      "  6   .�5<      ��  � {� . 62    5=      �� 5>       6&   �� *Text+$ 
TxtContent��  6W   .a�5?      ��  � {� .  6J   �� 5@       �@J�Opacity$	 0.8Q�68   6F   5A      5C      5E        5F   
   -   5        $��Spinner��5F   %   $	 Cog=�6      Spin . $y�Hidden=�6@   
 �iii�$	 0.8Q�6i      SpinDuration$ 2Q�6w   $��307,176,30,2q�6�     5G   
   -   5        $ TimesCircle=�5G      $ Close��6-   $
 Hand��6=   $��340,5,5,172q�6n   
 ����� J� RenderTransformOrigin$ 0.5,0.5&�6�     5H   
   -   5        $ MinusCircle=�5H      $ Minimize��6-   $
 Hand��6@   $��310,5,35,172q�6q   
 �����$ 0.5,0.5&�6�     5I   
   -	   5        $ QuestionCircle=�5I      $
 Help��60   $
 Hand��6?   $��282,5,65,172q�6p   
 �����$ 0.5,0.5&�6�   �� 5J   
   $��Addon Master��6   
���iii�$
��Bold"�6<   $
��Left=�6N   $��0,7,0,0q�6i   $	��Top=�6z   5K      5L      