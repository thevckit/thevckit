   M S B A M L   `   `   `  ����A  =XAML-2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XAML_2.CustomControlsXAML_2.CustomControls  5      2    ,XAML_2.CustomControls.TextBoxWithPlaceHolder   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:XAML_2.CustomControls     5      -   5          >�Name$  _this��5   .   $	��300��6    � 	Resources 5	         credentialTXTtitleStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� ElementName �� Value	 N� EnterActions
 g� 
SpeedRatio �� TargetProperty	 W� To	 t� To N� ExitActions  credentialTXTStyle��%�  &	        &	 �    �� 5
   
   " ��60   .�5      ��  � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � �� �#a3a3a36+   �� 5       � ��$ 20(�6)   �� 5       � ��$ Email��6%   �� 5       �@��Padding$	 2,0q�6(    5      �� 5       6   �� *Text+$ email��  6J   	 5      �� 5      .��5      �� $
 10Q�6)   .��5   "   W� $ FontSize�62   $ 20X�6W   t� 5   "   $ Margin�65   $ 0X�6X   5      5       5      �� 5      .��5       �� $
 10Q�6)   .��5!   "   W� $ FontSize�62   $ 15X�6W   t� 5"   "   $ Margin�65   $ 0 0 0 30X�6X   5#      5$      5&      5(      �� 5*   
   " ��6+   .�5+      ��  �@��TextAlignment$
 Left=�6.   �� 5,       � ��$ Center=�62   �� 5-       � ��$ SemiBold"�6+   �� 5.       � ��
 ���� 6+   �� 5/       � ��$ 0q�60   �� 50       � ��$	 2,0q�6(    53      �� 56       6   �� *
FontSize+$ title�� 156N   	 58      �� 59      .��5:      �� $
 10Q�6)   .��5;   "   W� $ FontSize�62   $ 20X�6W   t� 5<   "   $ Margin�65   $ 	0 20 0 0 X�6X   5=      5>       5B      �� 5C      .��5D      �� $
 10Q�6)   .��5E   "   W� $ FontSize�62   $ 15X�6W   t� 5F   "   $ Margin�65   $ 0X�6X   5G      5H      5J      5L      5M      .��5O      ��  �� CornerRadius$ 10��6   $��70��5P      
������� J� Effect 5S   
   3  -System.Windows.Media.Effects.DropShadowEffect  5T         
BlurRadius$ 23Q�6      ShadowDepth$ 5Q�5U         	Direction$	 270Q�5V         Color$ 
WhiteSmoke��5W      ._�5Y   
   � $
��20,6q�6   .+�5[      �� -   5         ��Name$ title��5[      #��[  5\      5]      �� 5_      -   5         ��Name$ email��5_      #��[ 5`      .��6@   5b      5c      5f      5g      