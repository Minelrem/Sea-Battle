   M S B A M L   `   `   `  ����D  @SeaBattle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SeaBattle	SeaBattle  5   	   7 clr-namespace:SeaBattle.ControlsSeaBattle.Controls  5   	       SeaBattle.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SeaBattle     5   	   5Controls clr-namespace:SeaBattle.Controls     5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��685��6)    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��330 �6   �� 5      $��* �6   .+�5   
      SeaBattle.Controls.Field  $
��Left=�6   $	��315��64   $��	10,10,0,0q�6A   $	��Top=�6T   $	��315��6l   $��0��6x   $��0��6�     5   
   -   5          Name$ 
EnemyField��5   6   $
��Left=�5      $	��315��64   $��	10,10,0,0q�6A   $	��Top=�6T   $	��315��6l      IsEnemy . $��0��5      $��1��6&   66   � 5   
   $
��Left=�6   $	��120��6*   $��	10,10,0,0q�67   $��1��6J   $��0��6W   $��2��6g   $	��Top=�6{   $	��660��6�   .+�5      �� -   5         ��Name$ button��5      $��Save to XML��6%   $
��Left=�6;   $��12,9,0,0q�6V   $	��Top=�6h   $��99��6�   6�   �� 5      -   5        $ button1��5      $��Load from XML��6&   $
��Left=�6>   $��	12,35,0,0q�6Y   $	��Top=�6l   $��99��6�   6�   5      5      5       