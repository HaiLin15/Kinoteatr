   M S B A M L   `   `   `  ����D  @Kinoteatr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Kinoteatr	Kinoteatr  5          Kinoteatr.PageDel   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Kinoteatr     5        N� Title$  PageDel��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5      $
��337* �6   �� 5      $	��54* �6   ��5   
   
� 5      .��5      �  � Color$ 	#FF3B44C3��6    � Offset$ 0.592Q�61   � 5      $ Black��6   $ 1Q�6-   5      .+�5   
   �� 
�������$��Удаление��6(   $��Center=�6;   $��Center=�6V   $��35(�6s   $��Comic Sans MS)�6�   $��51��6�   $	��180��6�   �� 5   
   -   5        $��10,0,704,13q�5      $��
Назад��6&    J� RenderTransformOrigin$ 
0.61,0.626&�66   6Y   &   System.Windows.Controls.DataGrid  5   
   -   5        $��MainDataGrid��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Название фильма��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *
NameFilm+  5      $ Жанр��6%   	 63   �� *Zanr+  5      $ Ограничение��6%   	 6:   �� *Ogranichenie+  5      $ Дата сеанса��6%   	 6:   �� *
Date_seans+
 �� StringFormat$
 
dd.MM.yyyy��  5      $ Время сеанса��6%   	 6;   �� *
time_seans+5%      �� 5&   
   -   5        $��УДАЛИТЬ��5&      $
��Left=�6#   $��2��6>   $��Center=�6K   $	��226��6f   $��10,0,0,0q�6�   �� 5'   
   -   5        $��Экспорт в Excel��5'      $
��Left=�6+   $��2��6F   $��Center=�6S   $	��150��6n   $��	250,0,0,0q�6{   6�   5+      5,      