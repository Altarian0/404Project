   M S B A M L   `   `   `  ����E  A404Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_404Project.VIews.Pages_404Project.VIews.Pages  5      &     _404Project.VIews.Pages.ShopPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:_404Project.VIews.Pages     5        N� Title$  Магазины��5	      .��5      � 
�������.+�5   
   �� -   5         ��Name$ ShopListBox��5      $��33,75,23,9.6q�6(   ��.  $��Visible=�6d   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $ Vertical=�6%   $��Center=�6<   .+�5      �� $��0 0 0 0q�6[   $��22(�6l   $��Center=�6z   ��6(   �� *Name+ �� StringFormat$ Магазин: {0}��6z   �� 5      $	��250��6%   $	��250��62   $
��Fill=�6>   ��6N   �� *	LogoImage+5      �� 5      $��5 0 0 0q�6#   {�.  ��64   �� *	Product+��5      �� 5   "   .R�5   &   � $��5q�60    � Orientation$ Vertical=�6;   .+�5   *   �� $��	0 0 20 00q�64   ��6G   �� *Name+$ Товар: {0}���� 5   *   $
��Wrap=�64   ��6H   �� *Description+$ Описание: {0}���� 5   *   ��65   �� *Price+$ Цена: {0} руб.���� 5    *   {�.  ��63   �� *ProductImage+��5!   .   �� 5"   2   .R�5#   6   �� $ 
Horizontal=�6A   5$   3   ��5&   .   �� 5'   2   .R�5(   6   �� $ 
Horizontal=�6A   .+�5)   :   �� $��0q�6@   $��50��6K   $��50��6V   ��6b   �� *Source+5*   7   5+   3   5-   +   5.   '   50   #   53      54      55      58      �� 59   
   -   5         ��Name$ EditShop��59      $��Right=�6#   $��Изменить��6?   $��40��6R   $	��150��6^   $	��Top=�6j   $��
0,30,205,0q�6�   6�   �� 5:   
   -   5        $ 
AddShopBtn��5:      $��Right=�6%   $��Добавить��6A   $	��150��6T   $��	0,30,50,0q�6`   $��40��6�   $	��Top=�6�   �� 5;   
   -   5        $ 	DeleteBtn��5;      $��Right=�6$   $��Удалить��6@   $��40��6R   $	��150��6^   $	��Top=�6j   $��
0,30,366,0q�6�   6�   �� 5<   
   -   5         ��Name$ 	SearchBox��5<      $	��201��6%   $��35��6V   $
��Left=�6b   $	��Top=�6}   $��	73,19,0,0q�6�   �� 5=   
   $��Поиск ��6   $��14(�6"    �� TextAlignment$ Center=�60   $��82��6G   $
��Left=�6R   $	��Top=�6m   $��0,24,0,0q�6�   5A      5B      