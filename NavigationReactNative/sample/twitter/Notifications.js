import React, {useContext} from 'react';
import {ScrollView, StyleSheet, Text, Image, FlatList, View, TouchableHighlight, ToolbarAndroid} from 'react-native';
import {NavigationContext} from 'navigation-react';
import {NavigationBarIOS} from 'navigation-react-native';

export default ({follows}) => {
  const {stateNavigator} = useContext(NavigationContext);
  return (
    <ScrollView contentInsetAdjustmentBehavior="automatic" style={styles.view}>
      <ToolbarAndroid title="Notifications" style={styles.toolbar} />
      <NavigationBarIOS title="Notifications" />
      <FlatList
          data={follows}
          keyExtractor={item => '' + item.id}
          renderItem={({item: {id, name, logo}}) => (
            <TouchableHighlight
              underlayColor="white"
              onPress={() => {
                stateNavigator.navigate('timeline', {id});
            }}>
            <View style={styles.follow}>
              <View>
                <Image style={styles.logo} source={logo} />
                <View style={styles.details}>
                <Text style={styles.name}>{name}</Text>
                <Text>followed you.</Text>
                </View>
              </View>
            </View>
          </TouchableHighlight>
        )} />
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  toolbar: {
    height: Platform.OS === 'android' ? 50 : 0,
  },
  view: {
    paddingLeft: 20,
    paddingRight: 20,
  },
  follow: {
    flexDirection: 'row',
    paddingTop: 10,
    paddingBottom: 15,
    borderBottomColor: '#ccd6dd',
    borderBottomWidth: 1,
  },
  icon: {
    marginRight: 10,
  },
  details: {
    flexDirection: 'row',
  },
  name: {
    fontWeight: 'bold',
    paddingRight: 4,
  },
  logo: {
    width: 35,
    height: 35,
    borderRadius: 17.5,
    marginRight: 5,
    marginBottom: 10,
  },
});
