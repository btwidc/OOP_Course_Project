   M S B A M L   `   `   `  ����F  BOnlineStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnlineStore.ViewOnlineStore.View  5   	   =#clr-namespace:OnlineStore.ViewModelOnlineStore.ViewModel  6:        OnlineStore.View.StoreList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1local1clr-namespace:OnlineStore.View     5   	   6local2#clr-namespace:OnlineStore.ViewModel     6:   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6m     � Title$  	StoreList��5   	   $	��500��6   $	��800��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��70 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   � $��2��6   ���#FC6C855      � 5   
   $��3��6   $��2��6   ���#FCB4D56C   � 5   
   $��0��6   $��2��6   ���#FC6C85.+�5      �� $	��150��6   $	��120��6!   ���#FC6C85��6C   Z� .��5      �� $!��Icons/store_icon_circle.png��6   5      5      � 5   
   $��2��6   $��1��6   ���#FCB4D5.+�5      �� $	��650��6   $��60��6$    �� Padding$ 8q�60   $7��1ДОБРО ПОЖАЛОВАТЬ В МАГАЗИН��6<   $��
-5,-50,0,0q�6^   
������� �� TextAlignment$ Center=�6�   $��Franklin Gothic Bold)�6�   $��40(�6�   �� 5      $	��650��6   $��60��6$   $ 8q�61   $&�� ПРИЯТНЫХ ПОКУПОК!��6=   
�������$��	-5,60,0,0q�6i   $ Center=�6|   $��Franklin Gothic Bold)�6�   $��40(�6�   5      � 5    
   $��1��6   $��1��6   ���#FCB4D55!      � 5"   
   $��2��6   .+�5#      �� -   5        $	��150��5#   ,   $	��270��68   ���#FC6C85��6   Z� .��5$      '  !MaterialDesignThemes.Wpf.PackIcon  $	��100��6*   $	��100��66      Kind$
 Cart=�6C   
�������$��Center=�6b   5%      5&      �� 5'   
   $��Bottom=�6   $��3��60   $��0��6=   ���#FC6C85.+�5(      �� -   5        ���#FC6C85$��70��5(   *   $��25(�6N   $��Franklin Gothic)�6\   $��
ВЫХОД��6y   ��66   Z� 6�   5)      �� 5*   
   $��0��6   $��1��6"   ���#FC6C85.+�5+      �� $'��!МАГАЗИН СЛАДОСТЕЙ��6   $��2q�60   $��60��6=   
�������$��1��6\   $��0��6l   $��Franklin Gothic)�6y   $��50(�6�   $��Center=�6�   $��Center=�6�   5,      5-      5.      