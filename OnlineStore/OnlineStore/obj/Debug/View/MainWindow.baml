   M S B A M L   `   `   `  ����F  BOnlineStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OnlineStore.ViewOnlineStore.View  5   	   !    OnlineStore.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OnlineStore.View     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Registration��5	   	   $	��500��6   $	��350��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5
      � .+�5   
   �� $	��200��6   $	��Top=�6!   ��5      �� 5       �� 
StartPoint$ 0.5,0&�6&    �� EndPoint$ 0.5,1&�69   .��5      �  � Color$ #FF1493��6#   � 5      $ #FC6C85��6#    � Offset$ 1Q�63   � 5      $ #FF43A4��6#   $	 0.5Q�63   5      5      �� 5   
   $��Icons/home_icon.png��6   $��90��6-   $��90��68   $	��Top=�6D   $��15q�6\   �� 5   
   $	��280��6   $	��290��6    
�������$��Bottom=�6:   $
��0,60q�6U    �� RadiusX$ 15��6c    �� RadiusY$ 15��6p   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$
 #FF43A4��6#      	Direction$ 0Q�63      
BlurRadius$ 15Q�6A      RenderingBias$ Quality=�6Q      ShadowDepth$ 1Q�6i   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $
��0,80q�6C   .+�5      �� $��РЕГИСТРАЦИЯ��6   $��Center=�6+   $	��Top=�6H   $	��-15q�6`   
�������$��Franklin Gothic)�6   $��20(�6�   �� 5      $��Center=�6   $��
10,0,10,25q�64   .+�5      �� -   5         ��Name$ Username_TextBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% ИМЯ ПОЛЬЗОВАТЕЛЯ��64    %  !MaterialDesignFloatingHintTextBox#��[  6f   $
��0,10q�6�   $��Champagne & Limousines)�6�   $��16(�6�   G� 5      -   5         G�Name$ Password_TextBox��5      $ ПАРОЛЬ��68    ) %MaterialDesignFloatingHintPasswordBox#��[ 6`   $
��0,10q�6�   $��Champagne & Limousines)�6�   $��16(�6�   G� 5      -   5        $ Confirm_Password_TextBox��5      $- 'ПОДТВЕРЖДЕНИЕ ПАРОЛЯ��6@   #��[ 6v   $
��0,10q�6�   $��Champagne & Limousines)�6�   $��16(�6�   5       5!      �� 5"   
   -   5        ���#FC6C85$��Bottom=�5"   &   $
��0,75q�6A   $	��180��6O   $*��$ЗАРЕГИСТРИРОВАТЬСЯ��6[   $��Franklin Gothic)�6x   6�   �� 5#   
   -   5        ���#FC6C85$��Center=�5#   &   $��Bottom=�6C   $
��0,15q�6^   $��Franklin Gothic)�6l   $	��200��6�   $%��Уже есть аккаунт?��6�   5$      5%      